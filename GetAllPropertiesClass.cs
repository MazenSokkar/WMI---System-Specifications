namespace WMI___System_Specifications
{
    internal class GetAllPropertiesClass
    {
        public static void GetProperties(string query)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection managementObjectCollection = searcher.Get();
            foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
            {
                foreach (PropertyData property in managementBaseObject.Properties)
                {
                    Console.WriteLine($"{property.Name} : {property.Value} ");
                }
            }
        }
    }
}
