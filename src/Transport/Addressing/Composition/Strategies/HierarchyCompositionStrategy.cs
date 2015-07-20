namespace NServiceBus.AzureServiceBus.Addressing
{
    using System;

    public class HierarchyCompositionStrategy : ICompositionStrategy
    {
        Func<string, string> _pathGenerator;

        public void SetPathGenerator(Func<string, string> pathGenerator)
        {
            _pathGenerator = pathGenerator;
        }

        public string GetEntityPath(string entityname)
        {
            return _pathGenerator(entityname) + entityname;
        }
    }
}