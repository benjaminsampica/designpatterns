namespace FactoryPattern.SimpleFactory
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
        }

        public override void Bake()
        {
            throw new System.NotImplementedException();
        }

        public override void Box()
        {
            throw new System.NotImplementedException();
        }

        public override void Cut()
        {
            throw new System.NotImplementedException();
        }

        public override void Prepare()
        {
            throw new System.NotImplementedException();
        }
    }
}