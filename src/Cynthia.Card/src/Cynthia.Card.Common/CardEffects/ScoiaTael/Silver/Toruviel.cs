using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
    [CardEffectId("53011")]//托露薇尔
    public class Toruviel : CardEffect
    {//伏击：对方放弃跟牌后翻开，使左右各2格内的单位获得2点增益。
        public Toruviel(GameCard card) : base(card) { }
        public override async Task<int> CardPlayEffect(bool isSpying, bool isReveal)
        {
            return 0;
        }
    }
}