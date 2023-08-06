using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPhoneBook;
    public enum EnumType : int
    {
        Ordered = 1,
        ReverseOrdered = 2,
        PeopleContained = 3,
        PeopleUntilD = 4

   }
    public class OrderedEnumerator : IEnumerator
    {
        private Person[] _PersonList;
        private int _index;
        public OrderedEnumerator(Person[] personList)
        {
            _PersonList = personList;
            _index = -1;
        }
        public object Current => _PersonList[_index];

        public bool MoveNext()
        {
            _index++;
            if (_index >= _PersonList.Length)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }

    public class ReverseOrderEnumerator : IEnumerator
    {
        private Person[] _PersonList;
        private int _index;
        public ReverseOrderEnumerator(Person[] personList)
        {
            _PersonList = personList;
            _index = _PersonList.Length;
        }
        public object Current => _PersonList[_index];

        public bool MoveNext()
        {
            _index--;
            if (_index <= 0)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _index = _PersonList.Length;
        }
    }
    public class PeopleContainEnumerator : IEnumerator
    {
        private Person[] _PersonList;
        private string _ContainedLetter;
        private int _index;
        public PeopleContainEnumerator(Person[] personList,string containedLetter)
        {
            _PersonList = personList;
            _index = -1;
            _ContainedLetter = containedLetter;
        }
        public object Current => _PersonList[_index];

        public bool MoveNext()
        {
            _index++;
            if (_index >= _PersonList.Length)
            {
                return false;
            }
            var person = _PersonList[_index];
            if (!person.Name.Contains(_ContainedLetter))
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }

public class PeopleUntilLetterEnumerator : IEnumerator
{
    private Person[] _PersonList;
    private string _UntilLetter = "D";
    private int _index;
    private bool isStop = false;
    public PeopleUntilLetterEnumerator(Person[] personList)
    {
        _PersonList = personList;
        _index = -1;

    }
    public object Current => _PersonList[_index];

    public bool MoveNext()
    {
        if (isStop)
        {
            return false;
        }
        _index++;
        if (_index >= _PersonList.Length)
        {
            return false;
        }
        var person = _PersonList[_index];
        if (person.Name.StartsWith(_UntilLetter))
        {
            isStop = true;
            return false;
        }
        return true;
    }

    public void Reset()
    {
        _index = -1;
    }
}

