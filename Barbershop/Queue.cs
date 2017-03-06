using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Queue
    {
        private List<QueuePlace> queue;
        private int elementsCount;

        private int timeNewClient;
        private int currentTimeNewClient;

        public Queue(int queueSize, int timeNewClient)
        {
            elementsCount = queueSize;
            queue = new List<QueuePlace>();
            this.timeNewClient = timeNewClient;
        }

        public void PushNewClient(QueuePlace client)
        {
            if(queue.Count <= elementsCount)
            {
                queue.Add(client);
            }
        }

        public QueuePlace PopClient()
        {
            QueuePlace firstClient = null;
            if (queue.Count > 0)
            {
                firstClient = queue.First();
                queue.Insert(0, queue.First());
            }
            return firstClient;
        }

        public 

    }
}
