using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace Tests_Project__Lab_1_
{
    class LogicalInferenceMechanism
    {
        private XDocument xml;
        private string path;
        private WorkMemory workMemory;

        public LogicalInferenceMechanism(WorkMemory workMemory)
        {
            path = Directory.GetCurrentDirectory() + "base.xml";
            xml = XDocument.Load(path);
            this.workMemory = workMemory;
        }

        public Tuple<string, string> GetQuestionAndCurrentDefruleName() // получение текста следующего вопроса и имени соответствующего правила
        {
            string defName = string.Empty, questionText = string.Empty;

            foreach (var defrule in xml.Root.Descendants())
            {
                if (!defrule.HasElements && !workMemory.IsFactСontained(defrule.Attribute("name").Value))
                {
                    defName = defrule.Attribute("name").Value;
                    questionText = defrule.Attribute("question").Value;
                    break;
                }
            }

            return Tuple.Create(questionText, defName);
        }

        public Tuple<string, bool> DefrulesEnumeration() // перебор правил и добавление выведенных фактов в РП (возвращает имя последнего выведенного факта)
        {
            string factName = null;
            bool systemExit = false;

            foreach (XElement defrule in xml.Root.Elements())
            {
                if (defrule.HasElements) // если элемент не имеет дочерних элементов (предпосылок), нет смысла проверять его, т.к. финальный вывод состоит из нескольких предпосылок
                {
                    int premisesCount = defrule.Elements().Count(), equalsPairsCount = 0;

                    foreach (XElement premise in defrule.Elements())
                    {
                        foreach (Fact fact in workMemory.GetFactsList())
                        {
                            if (fact.Name == premise.Attribute("name").Value && fact.Value == premise.Attribute("value").Value) // если имена факта из РП и предпосылки совпадают и совпадают их значения, то счетчик сравнения тикает
                                equalsPairsCount++;
                        }
                    }

                    if (equalsPairsCount == premisesCount && !workMemory.IsFactСontained(defrule.Attribute("name").Value)) // если кол-во "равных" пар и кол-во предпосылок текущего правила равны, это означает, что можно занести новый выведенный факт в РП
                    {
                        factName = defrule.Attribute("name").Value;
                        workMemory.Add(new Fact(factName, "да"));
                        //break;

                        foreach (XAttribute attribute in defrule.Attributes()) // если факт добавлен в РП, стоит проверить, не является ли он университетом, т.е. элементом со значением атрибута ruleType равным "university"
                            if (attribute.Name == "ruleType" && attribute.Value == "university")
                            {
                                systemExit = true;
                                break;
                            }
                    }
                }
            }

            return Tuple.Create(factName, systemExit);
        }

        public int GetQuestionsCount()
        {
            int count = 0;

            foreach (var elem in xml.Root.Elements())
            {
                foreach (var attribute in elem.Attributes())
                    if (attribute.Name == "question")
                    {
                        count++;
                        break;
                    }
            }

            return count;
        }
    }
}
