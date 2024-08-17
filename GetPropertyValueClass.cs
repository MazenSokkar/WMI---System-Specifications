namespace WMI___System_Specifications
{
    internal class GetPropertyValueClass
    {
        public static void GetPropertyValue(string query, string propertyName)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection managementObjectCollection = searcher.Get();
            foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
            {
                foreach (PropertyData property in managementBaseObject.Properties)
                {
                    if (property.Name.Equals(propertyName))
                    {
                        Console.WriteLine($"{property.Name} : {property.Value}");
                    }
                }
            }
        }
    }
}
