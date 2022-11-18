namespace Worker
{
    public class Person
    {
        private string name;                             // object fields
        private string lastName;
        private byte age;
        private char sex;
        private byte skillLevel;
        private byte absenseFromWorkInDays;
        private bool fired;
        private bool poluchilPovestku;


        public Person(string name, string lastName, byte age, char sex, byte skillLevel, byte absenseFromWorkInDays, bool fired, bool poluchilPovestku)
        {
            this.name = name;                           // set initial object values data
            this.lastName = lastName;
            this.age = age;
            this.sex = sex;
            this.skillLevel = skillLevel;
            this.absenseFromWorkInDays = absenseFromWorkInDays;
            this.fired = fired;
            this.poluchilPovestku = poluchilPovestku;
        }

        public void SetMainData(string name, string last_name, byte age, char sex, byte skill_level, byte absense_from_work_in_days, bool fired, bool poluchil_povestku)
        {
            this.name = name;                             // set object values data
            this.lastName = last_name;
            this.age = age;
            this.sex = sex;
            this.skillLevel = skill_level;
            this.absenseFromWorkInDays = absense_from_work_in_days;
            this.fired = fired;
            this.poluchilPovestku = poluchil_povestku;
        }

        public string GetName()                        // get 'name' object value
        {
            return this.name;
        }

        public string GetLastName()                   // get 'last_name' object value
        {
            return this.lastName;
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
            return this.skillLevel;
        }

        public byte GetAbsenseFromWorkInDays()          // get 'absense_from_work_in_days' object value
        {
            return this.absenseFromWorkInDays;
        }

        public bool IsFired()                         // get 'fired' object value
        {
            return this.fired;
        }

        public bool GetPoluchilPovestkuValue()         // get 'poluchil_povestku' object value
        {
            return this.poluchilPovestku;
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
                this.poluchilPovestku = true;
            }
        }

       
    }
}