using DryIoc;
using System; 

namespace SbCr.Support.Container
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new DryIoc.Container();

            container.Register<IMySuperService, MySuperServiceImpl>(Reuse.Transient);
            container.Register<IMyWorker, MyWorkerImpl>();



            var worker = container.Resolve<IMyWorker>();

            worker.Work();

            var worker2 = container.Resolve<IMyWorker>();

            worker2.Work();

            System.Console.ReadLine();
        }
    }


    public interface IMyWorker
    {
        void Work();
    }

    internal class MyWorkerImpl : IMyWorker
    {
        private readonly IMySuperService _mySuperService;
        public MyWorkerImpl(IMySuperService superService)
        {
            _mySuperService = superService;
        }
        public void Work()
        {
         
            _mySuperService.Start();
            _mySuperService.Stop();

        }
    }


    public interface IMySuperService
    {
        void Start();

        void Stop();
    }


    internal class MySuperServiceImpl : IMySuperService
    {
        private int _counter = 1;



        public void Start()
        {
            _counter++;

            Console.WriteLine("Start");

            Console.WriteLine(_counter.ToString());

        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
