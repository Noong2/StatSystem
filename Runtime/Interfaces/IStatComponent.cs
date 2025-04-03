using System.Collections.Generic;

namespace Noong2.StatSystem
{
    public interface IStatComponent
    {
        bool HasStat(string statName);

        float GetStatValue(string statName);

        void SetStatValue(string statName, float value);

        IStat GetStatDefinition(string statName);

        Dictionary<string, float> GetAllStats();

        void AddStat(IStat stat, float initialValue = float.MinValue);
        
        void RemoveStat(IStat stat);

        void Damaged(IStatModifier modifier);
    }
} 