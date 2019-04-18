using System;

namespace AbsractFactoryExample.BirdFactory
{
    public class MainClass
    {
        
        public static void Main()
        {
            BirdFactory africa = new AfricaFactory();
            BirdWorld world = new BirdWorld(africa);
            world.RunFoodChain();


            BirdFactory america = new AmericaFactory();
            world = new BirdWorld(america);
            world.RunFoodChain();

         
            Console.ReadKey();
        }
    }

    

    abstract class BirdFactory

    {
        public abstract Fly CreateFlyingBird();
        public abstract NonFly CreateNonFlyingBird();
    }

    class AfricaFactory : BirdFactory

    {
        public override Fly CreateFlyingBird()
        {
            return new KoriBusturd();
        }
        public override NonFly CreateNonFlyingBird()
        {
            return new Ostrich();
        }
    }

    class AmericaFactory : BirdFactory

    {
        public override Fly CreateFlyingBird()
        {
            return new Condor();
        }
        public override NonFly CreateNonFlyingBird()
        {
            return new Rheas();
        }
    }


    abstract class Fly

    {
    }

 

    abstract class NonFly

    {
        public abstract void Height(Fly h);
    }


    class KoriBusturd : Fly

    {
    }

    

    class Ostrich : NonFly

    {
        public override void Height(Fly h)
        {


            Console.WriteLine(this.GetType().Name +
              " is larger than " + h.GetType().Name);
        }
    }


    class Condor : Fly

    {
    }


    class Rheas : NonFly

    {
        public override void Height(Fly h)
        {

            Console.WriteLine(this.GetType().Name +
              " is larger than " + h.GetType().Name);
        }
    }

    

    class BirdWorld

    {
        private Fly _fly;
        private NonFly _nonfly;
       

        public BirdWorld(BirdFactory factory)
        {
            _nonfly = factory.CreateNonFlyingBird();
            _fly = factory.CreateFlyingBird();
        }

        public void RunFoodChain()
        {
            _nonfly.Height(_fly);
        }
    }
}
