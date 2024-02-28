using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace aspose.pdf.annotation;

class ArgsCli
{
    public object CreateModel(string[] args)
    {
        Console.WriteLine("PDF annotation CLI");

        if (args.Length == 0)
        {
            Console.WriteLine("Usage: dotnet run modelName.fieldName=value [modelName.fieldName=value ...]");
            return null;
        }

        // Parse command line arguments into a dictionary
        var modelData = new Dictionary<string, Dictionary<string, string>>();
        foreach (var arg in args)
        {
            var parts = arg.Split(new[] { '=' }, 2);
            if (parts.Length != 2)
            {
                Console.WriteLine($"Invalid argument format: {arg}");
                return null;
            }

            var modelField = parts[0].Split('.');
            if (modelField.Length != 2)
            {
                Console.WriteLine($"Invalid model-field format: {parts[0]}");
                return null;
            }

            var modelName = modelField[0];
            var fieldName = modelField[1];
            var fieldValue = parts[1];

            if (!modelData.ContainsKey(modelName))
            {
                modelData[modelName] = new Dictionary<string, string>();
            }

            modelData[modelName][fieldName] = fieldValue;
        }

        // Create and populate the model instance
        foreach (var modelEntry in modelData)
        {
            var modelName = modelEntry.Key;
            var fieldData = modelEntry.Value;

            Type modelType = Type.GetType($"{modelName}, ConsoleApp");
            if (modelType == null)
            {
                Console.WriteLine($"Invalid model type: {modelName}");
                return null;
            }

            object model = Activator.CreateInstance(modelType);
            FillModelFields(model, fieldData);

            Console.WriteLine($"Model {modelName} created successfully.");
            return model;
        }

        return null;
    }

    static void FillModelFields(object model, Dictionary<string, string> fieldData)
    {
        Type modelType = model.GetType();
        PropertyInfo[] properties = modelType.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            if (fieldData.TryGetValue(property.Name, out string fieldValue))
            {
                Type propertyType = property.PropertyType;
                object convertedValue = Convert.ChangeType(fieldValue, propertyType);
                property.SetValue(model, convertedValue);
            }
            else if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
            {
                object nestedModel = Activator.CreateInstance(property.PropertyType);
                FillModelFields(nestedModel, fieldData);
                property.SetValue(model, nestedModel);
            }
        }
    }
}