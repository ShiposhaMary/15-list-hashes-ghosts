//using System;
//using System.Text;

//namespace hashes
//{
//	public class GhostsTask : 
//		IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>, 
//		IMagic
//	{
//		public void DoMagic()
//		{
//		}

//		// Чтобы класс одновременно реализовывал интерфейсы IFactory<A> и IFactory<B> 
//		// придется воспользоваться так называемой явной реализацией интерфейса.
//		// Чтобы отличать методы создания A и B у каждого метода Create нужно явно указать, к какому интерфейсу он относится.
//		// На самом деле такое вы уже видели, когда реализовывали IEnumerable<T>.

//		Vector IFactory<Vector>.Create()
//		{
//			throw new NotImplementedException();
//		}

//		Segment IFactory<Segment>.Create()
//		{
//			throw new NotImplementedException();
//		}

//		// И так даллее по аналогии...
//	}
//}
using System;
using System.Text;

namespace hashes
{
    public class My_GhostsTask :
        IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>,
        IMagic
    {
        private byte[] documentArray = { 1, 1, 2 };
        Document document;
        Segment segment;
        Cat cat = new Cat("Silver", "11 flore", DateTime.MaxValue);
        Vector vector = new Vector(0, 0);
        Robot robot = new Robot("Robot");

        public My_GhostsTask()
        {
            segment = new Segment(vector, vector);
            document = new Document("My favorites", Encoding.Unicode, documentArray);
        }

        public void DoMagic()
        {
            documentArray[0] = 10;
            vector.Add(new Vector(2, 28));
            cat.Rename("Silvestr");
            Robot.BatteryCapacity++;
        }

        Document IFactory<Document>.Create()
        {
            return document;
        }

        Vector IFactory<Vector>.Create()
        {
            return vector;
        }

        Segment IFactory<Segment>.Create()
        {
            return segment;
        }

        Cat IFactory<Cat>.Create()
        {
            return cat;
        }

        Robot IFactory<Robot>.Create()
        {
            return robot;
        }
    }
}