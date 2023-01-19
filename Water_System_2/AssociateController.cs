namespace Water_System_2
{
    public class AssociateController
    {
        public List<Associate> AssociateList = new();
        public AssociateController(List<Associate> associateList)
        {
            this.AssociateList = associateList;
        }
        public AssociateController() { }

        public int AddAssociate(Associate associate)
        {
            if (FindNumberOfDigits(associate.MeterId) == 6)
            {
                if (AssociateList.Count > 0)
                {
                    foreach (Associate asso in AssociateList)
                    {
                        if (asso.MeterId == associate.MeterId)
                        {
                            throw new Exception("The meter ID is already registered to another associate");
                        }
                        else
                        {
                            AssociateList.Add(associate);
                            return 1;
                        }
                    }

                }
            }
            else
            {
                throw new Exception("Meter ID has Not A Valid Format");
            }
            return 1;
        }

        public int FindNumberOfDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
    }
}