using RimWorld;
using Verse;

namespace ChickenTraits
{
    public class ThoughtWorker_GermophobeRoomCleanliness : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            Room room = p.GetRoom(RegionType.Set_All);
            if (room==null || room.PsychologicallyOutdoors || room.IsDoorway)
            {
                return ThoughtState.Inactive;
            }
            int scoreStageIndex = RoomStatDefOf.Cleanliness.GetScoreStageIndex(room.GetStat(RoomStatDefOf.Cleanliness));
            if (this.def.stages[scoreStageIndex] == null)
            {
                return ThoughtState.Inactive;
            }
            return ThoughtState.ActiveAtStage(scoreStageIndex);
        }
    }
}
