using System;

namespace Lab5 {

    public class MyEventArgs : EventArgs {
        public MyEventArgs (string data) {
            this.data = data;
        }

        private string data;

        public string Data {
            get { return data; }
        }
    }


    public class ClassA {

        public event EventHandler<MyEventArgs> event_news;

        public void Send () {
            event_news?.Invoke (this, new MyEventArgs ("Có tin mới Abc ..."));
        }
    }

    public class ClassB {
        public void Sub (ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher (object sender, MyEventArgs e)
        {
            Console.WriteLine ("ClassB: " + e.Data);
        }
    }


    public class ClassC {
        public void Sub (ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher (object sender, MyEventArgs e)
        {
            Console.WriteLine ("ClassC: " + e.Data);
        }
    }
    public class EX2_2_Event {
        public static void run()
        {
            ClassA p  = new ClassA();
            ClassB sa = new ClassB();
            ClassC sb = new ClassC();

            sa.Sub (p); 
            sb.Sub (p); 

            p.Send ();
        }
    }
}