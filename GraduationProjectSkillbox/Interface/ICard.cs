using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationProjectSkillbox.Models;

namespace GraduationProjectSkillbox.Interface
{
    public interface ICard<T>
    {
        IEnumerable<T> GetCards();
        void AddCard(T value);
        void DeleteCard(T value);
        void EditCard(T value);
        T GetCardOnId(int? id);
    }
}
