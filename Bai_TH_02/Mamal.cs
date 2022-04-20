using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_TH_02
{
    abstract class Mamal
    {
        public string? Characteristic { get; set; }

    }

    public interface IAbility
    {

    }

    public interface IThinking : IAbility
    {
        public void Thinking_behavior();
    }

    public interface IIntelligent : IAbility
    {
        public void Intelligent_behavior();
    }


    class Whale : Mamal
    {
        public Whale() { }
    }

    class Human: Mamal
    {
        public Human() { }

    }
}
