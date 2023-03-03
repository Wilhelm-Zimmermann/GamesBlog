namespace GamesBlog.Domain.Entitties
{
    public class Base
    {
        public Guid Id { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }

    }
}
