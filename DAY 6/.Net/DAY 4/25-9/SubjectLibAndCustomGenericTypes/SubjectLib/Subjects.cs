using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectLib
{
   public interface IId<T>
    {
        T Id { get; set; }
    }

    public class MyGenricWrapping<Tid,TVal> where TVal: IId<Tid>
    {
        Dictionary<Tid, TVal> items;
        public MyGenricWrapping()
        {
            items = new Dictionary<Tid, TVal>();
        }


        public void Add(TVal item)
        {
            if (items.ContainsKey(item.Id))
            {
                throw new ExceptionLayer
                    .DuplicateKeyException("Subject already added");
            }
            else
            {
                items.Add(item.Id, item);
            }
        }
    }

    public class Subjects : IDisposable
    {
        Dictionary<int, Subject> subjects;

        public Subjects()
        {
            subjects = new Dictionary<int, Subject>();
        }

        public void Add(Subject subject)
        {
            if(subjects.ContainsKey(subject.Id))
            {
                throw new ExceptionLayer
                    .DuplicateKeyException("Subject already added");
            }else
            {
                subjects.Add(subject.Id, subject);
            }
        }

        public Subject Find(int id)
        {
            //check for id aviable in dict or throw exception
            return subjects[id];
        }
        public void Remove(int id)
        {
            //check for id aviable in dict or throw exception
            subjects.Remove(id);
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return subjects.Values;
        }

        public void Dispose()
        {
            subjects = null;
        }
    }
}
