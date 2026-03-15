namespace Patterns.Facade.Basic
{
    public class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;

        public Facade(SubsystemA subsystemA, SubsystemB subsystemB)
        {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
        }

        public void Operation()
        {
            _subsystemA.Operation();
            _subsystemB.Operation();
        }
    }
}