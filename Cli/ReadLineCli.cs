using System;
using System.Reflection;

namespace aspose.pdf.annotation;

class ReadLineCli
{
    public object CreateModel()
    {
        Console.WriteLine("PDF annotation CLI");
        Console.WriteLine("model: ");
        var modelName = Console.ReadLine();

        object model = Activator.CreateInstance(
            "aspose.pdf.annotation", 
            "aspose.pdf.annotation.Model" + modelName + "Model");

        FillModelFields(model);

        Console.WriteLine("Model created successfully.");
        return model;
    }

    static void FillModelFields(object model)
    {
        Type modelType = model.GetType();
        PropertyInfo[] properties = modelType.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            Type propertyType = property.PropertyType;
            object defaultValue = propertyType.IsValueType ? Activator.CreateInstance(propertyType) : null;

            Console.Write($"{property.Name} [{defaultValue}]: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                property.SetValue(model, defaultValue);
            }
            else if (propertyType.IsEnum)
            {
                property.SetValue(model, Enum.Parse(propertyType, input));
            }
            else if (propertyType == typeof(string))
            {
                property.SetValue(model, input);
            }
            else if (propertyType == typeof(double))
            {
                property.SetValue(model, double.Parse(input));
            }
            else if (propertyType == typeof(bool))
            {
                property.SetValue(model, bool.Parse(input));
            }
            else if (propertyType.IsClass && propertyType != typeof(string))
            {
                object nestedModel = Activator.CreateInstance(propertyType);
                FillModelFields(nestedModel);
                property.SetValue(model, nestedModel);
            }
        }
    }
}