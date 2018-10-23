using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// 
    /// Make fine grained interfaces that are client specific. (Clients should not be forced to depend upon interfaces that they do not use.)
    /// </summary>

    #region Prob

    public interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }
    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task  
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
        }
    }
    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task.  
        }
        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }

    #endregion

    #region soln
    public interface IProgrammer
    {
        void WorkOnTask();
    }
    public interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            //code to implement to work on the Task.  
        }
    }
    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            //Code to create a sub taks from a task.  
        }
    }

    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task from a task.  
        }
        public void WorkOnTask()
        {
            //code to implement to work on the Task.  
        }
    }
    #endregion
}
