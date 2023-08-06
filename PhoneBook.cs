using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPhoneBook;
public class PhoneBook : IEnumerable, IReverseOrder, IPeopleUntil
{
    public Person[] PersonList { get; set; }
    public IEnumerator GetEnumerator()
    {
        return new OrderedEnumerator(PersonList);
    }

    IEnumerator IReverseOrder.GetEnumerator()
    {
        return new ReverseOrderEnumerator(PersonList);
    }
 
    IEnumerator IPeopleUntil.GetEnumerator()
    {
        return new PeopleUntilLetterEnumerator(PersonList);
    }


    public IEnumerable AllPeopleReversed
    {
        get
        {
            var result = (IReverseOrder)this;

            return (IEnumerable)result; 
        }
    }

    public IEnumerable PeopleContains(string containedLetter)
    {
        foreach (Person per in this)
        {
            if (per.Name.Contains(containedLetter))
            {
                yield return per;
            }
        }       
    }


    public IEnumerable PeopleUntilD
    {
        get
        {
            var result = (IPeopleUntil)this;
            return (IEnumerable)result;
        }
    }

   
}

