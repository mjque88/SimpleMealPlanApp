using System;
using System.IO;
using System.Xml.Serialization;

namespace SimpleMealPlanApp.Models
{
    [Serializable]
    public class MealFontSize
    {
        public double UserMealFontSize { get; set; }

        public void Save(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer MealFontSize = new XmlSerializer(typeof(MealFontSize));
                MealFontSize.Serialize(stream, this);
            }
        }

        public static MealFontSize LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var MealFontSize = new XmlSerializer(typeof(MealFontSize));
                return (MealFontSize)MealFontSize.Deserialize(stream);
            }
        }
    }
}
