namespace Patterns.CSharp.Patterns.Facade
{
    public class Facade
    {
        private SubSystemA subSystemA = new SubSystemA();
        private SubSystemB subSystemB = new SubSystemB();
        private SubSystemC subSystemC = new SubSystemC();
        private SubSystemD subSystemD = new SubSystemD();

        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
        }

        public void OperationCD()
        {
            subSystemC.OperationC();
            subSystemD.OperationD();
        }
    }
}