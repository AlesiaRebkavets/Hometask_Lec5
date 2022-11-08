namespace Worker
{
    public class Person
    {
        private string name;                             // object fields
        private string last_name;
        private byte age;
        private char sex;
        private byte skill_level;
        private byte absense_from_work_in_days;
        private Boolean fired;
        private Boolean poluchil_povestku;


        public Person(string name, string last_name, byte age, char sex, byte skill_level, byte absense_from_work_in_days, Boolean fired, Boolean poluchil_povestku)
        {
            this.name = name;                           // set initial object values data
            this.last_name = last_name;
            this.age = age;
            this.sex = sex;
            this.skill_level = skill_level;
            this.absense_from_work_in_days = absense_from_work_in_days;
            this.fired = fired;
            this.poluchil_povestku = poluchil_povestku;
        }

        public Person()
        {
        }

        public void SetMainData(string name, string last_name, byte age, char sex, byte skill_level, byte absense_from_work_in_days, Boolean fired, Boolean poluchil_povestku)
        {
            this.name = name;                             // set object values data
            this.last_name = last_name;
            this.age = age;
            this.sex = sex;
            this.skill_level = skill_level;
            this.absense_from_work_in_days = absense_from_work_in_days;
            this.fired = fired;
            this.poluchil_povestku = poluchil_povestku;
        }

        public string GetName()                        // get 'name' object value
        {
            return this.name;
        }

        public string GetLastName()                   // get 'last_name' object value
        {
            return this.last_name;
        }

        public byte GetAge()                          // get 'age' object value
        {
            return this.age;
        }

        public char GetSex()                           // get 'sex' object value
        {
            return this.sex;
        }
        
        public byte GetSkillLevel()                     // get 'skill_level' object value
        {
            return this.skill_level;
        }

        public byte GetAbsenseFromWorkInDays()          // get 'absense_from_work_in_days' object value
        {
            return this.absense_from_work_in_days;
        }

        public Boolean IsFired()                         // get 'fired' object value
        {
            return this.fired;
        }

        public Boolean GetPoluchilPovestkuValue()         // get 'poluchil_povestku' object value
        {
            return this.poluchil_povestku;
        }

        public void Fire(byte absense_from_work_in_days)      // worker is fired if his days of absense > 0
        {
            if (absense_from_work_in_days > 0)
            {
                this.fired = true;
            }
        }

        public void Voenkom(char sex)                       // voenkom on factory :(
        {
            if (sex == 'm')
            {
                this.poluchil_povestku = true;
            }
        }
    }
}