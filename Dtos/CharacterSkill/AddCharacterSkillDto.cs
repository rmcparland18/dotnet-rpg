using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.CharacterSkill
{
    public class AddCharacterDto
    {
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
    }
}
