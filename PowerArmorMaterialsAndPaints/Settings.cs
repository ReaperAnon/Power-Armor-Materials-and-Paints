using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.FormKeys.Fallout4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace PowerArmorMaterialsAndPaints
{
    public class ModSettings
    {
        [Tooltip("A list of the keywords power armors use for materials. Some mods add new ones which need to be added to this list so they can be changed when necessary.")]
        public List<FormLink<IKeywordGetter>> MaterialKeywords { get; set; } = new List<FormLink<IKeywordGetter>>() { Fallout4.Keyword.ap_PowerArmor_Paint };
    }
}
