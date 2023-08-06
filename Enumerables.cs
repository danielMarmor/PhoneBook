using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPhoneBook
{
    public interface IReverseOrder   {
        IEnumerator GetEnumerator();
    }

    public interface IPeopleContain
    {
        IEnumerator GetEnumerator();
    }

    public interface IPeopleUntil
    {
        IEnumerator GetEnumerator();
    }
}
