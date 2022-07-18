namespace Esstra.Hit.Client.Annotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityAttribute : Attribute
    {
        public EntityAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
