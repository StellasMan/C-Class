using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    public class Animal
    {
        public Animal(int numberOfLegs)
        {
            m_nNumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return m_nNumberOfLegs;
            }
        }

        private int m_nNumberOfLegs;
    }

    public class Mammal : Animal
    {
        public Mammal(bool isCarnivorous, int numberOfLegs)
            : base(numberOfLegs)
        {
            m_bIsCarnivorous = isCarnivorous;
        }

        public readonly bool m_bIsCarnivorous;
    }

    public class Amphibian : Animal
    {
        public Amphibian(bool isPoisonous)
            : base(4)
        {
            m_bIsPoisonous = isPoisonous;
        }

        public bool IsPoisonous
        {
            get
            {
                return m_bIsPoisonous;
            }
        }

        private bool m_bIsPoisonous;
    }

    public class Human
    {
        public Human(string sName)
        {
            m_sName = sName;
        }

        public Human(string sName, DateTime dtBirth)
            : this(sName)
        {
            m_dtBirthDate = dtBirth;
        }

        public string Name
        {
            get
            {
                return m_sName;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return (m_dtBirthDate.HasValue) ? m_dtBirthDate.Value : DateTime.Now;
            }
        }

        private string m_sName;
        private DateTime? m_dtBirthDate = null;
    }
}
