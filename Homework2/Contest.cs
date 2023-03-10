using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Contest
    {
        public List<Participant> listOfParicipants = new List<Participant>();


        public void AddNewParticipantAtEndOfList(Participant newParticipant)
        {
            if (IsIdUnique(newParticipant.id))
            {
                this.listOfParicipants.Add(newParticipant);
            }
            else
            {
                Console.WriteLine("Id:" + newParticipant.id + " is not unique.");
            }
            
        }

        public void AddNewParticipantAtPozitionInList(Participant newParticipant, int position)
        {
            if (!IsPositionAvailableToAdd(position))
            {
                Console.WriteLine("Position " + position +
                    " is not available, maximal available position is: " + GetMaxAvailablePosition() );
                return;
            }
            if (!IsIdUnique(newParticipant.id))
            {
                Console.WriteLine("Id:" + newParticipant.id + " is not unique.");
                return;
            }
            listOfParicipants.Insert(position-1, newParticipant);
        }

        public bool IsPositionAvailableToAdd(int positionToCheck)
        {
            return positionToCheck <= this.listOfParicipants.Count+1;
        }

        public bool IsPositionAvalibleToDelete(int positionToCheck)
        {
            return IsPositionAvailableToAdd(positionToCheck + 1);
        }


        public int GetMaxAvailablePosition()
        {
            return this.listOfParicipants.Count;
        }

        public void DeleteByPosition(int position)
        {
            if (IsPositionAvalibleToDelete(position))
            {
                listOfParicipants.RemoveAt(position-1);
            }
            else
            {
                Console.WriteLine("No participans at pozition: " + 
                    position + "maximal avalible position is: " + GetMaxAvailablePosition());
            }
        }

        public bool IsIdUnique(int id)
        {
            bool flag = true;
            foreach (Participant p in listOfParicipants)
            {
                if(p.id == id)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public bool IsIdValid(int id)
        {
            return !IsIdUnique(id);
        }

        public void ChangeScoreById(int id, int newScore)
        {
            if (IsIdValid(id))
            {
                foreach (Participant p in listOfParicipants)
                {
                    if(p.id == id)
                    {
                        p.score = newScore;
                    }
                }
            }
            else
            {
                Console.WriteLine("Cant faind a participant with id: " + id);
            }
        }

        public void PrintParticipantsWintScoreUnder(int scoreLimit)
        {
            foreach(Participant p in listOfParicipants)
            {
                if(p.score< scoreLimit)
                {
                    p.Print();
                }
            }
        }

        public void SortByScoreAscending()
        {
            listOfParicipants.Sort((x, y) => { 
                if(x.score < y.score)
                    return x.score; 
                else
                    return y.score;
            });  
        }

        public void SortByScoreDescending()
        {
            listOfParicipants.Sort((x, y) => {
                if (x.score > y.score)
                    return x.score;
                else
                    return y.score;
            });
        }

        public void PrintParticipantsAscByScoreOver(int scoreLimit)
        {
            SortByScoreAscending();
            foreach(Participant p in listOfParicipants)
            {
                if(p.score > scoreLimit)
                {
                    p.Print();
                }
            }
        }

        public void PrintParticipants()
        {
            Console.WriteLine("List of participants is:");
            foreach (Participant p in listOfParicipants)
            {
                p.Print();
            }
            Console.WriteLine();
        }


        public float ScoreMeanInPositionInterval(int position1, int position2)
        {
            float sum = 0;
            
            int index;

            if(IsPositionAvalibleToDelete(position1)&&IsPositionAvalibleToDelete(position2))
            {
                for(index = Math.Min(position1, position2) -1 ; index < Math.Max(position1,position2); index++)
                {
                    sum += listOfParicipants.ElementAt(index).score;
                }
                return sum / Math.Abs(position2 - position2);
            }
            else
            {
                Console.WriteLine("Positions are not avalible");
                return 0;
            }


        }
    }
}
