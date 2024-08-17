namespace WMI___System_Specifications
{
    internal class PropertiesCollection
    {
        // NOT COMPLETED YET
        static List<string> GetAllProperties(string query)
        {
            List<string> allProperties = new();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection managementObjectCollection = searcher.Get();
            foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
            {
                foreach (PropertyData property in managementBaseObject.Properties)
                {
                    allProperties.Add(property.Name.ToString());
                }
            }
            return allProperties;
        }
    }
}
