using System;
using System.Collections.Generic;

namespace MoPhongNhanSinh.Core
{
    [Serializable]
    public class StatBlock
    {
        public float the;
        public float linh;
        public float ngo;
        public float than;
        public float tam;
        public float van;
        public float luc;
        public float thu;
        public float toc;
        public float tc;
        public float pb;
    }

    [Serializable]
    public class MetaData
    {
        public string appVersion;
        public string[] realms;
        public int[] life;
        public BodyDef[] bodies;
        public RootDef[] roots;
    }

    [Serializable]
    public class BodyDef
    {
        public string n;
        public float c;
        public int a;
    }

    [Serializable]
    public class RootDef
    {
        public string n;
        public string el;
        public float c;
    }

    [Serializable]
    public class TalentDef
    {
        public string id;
        public string n;
        public int r;
        public StatBlock e;
    }

    [Serializable]
    public class ItemDef
    {
        public string id;
        public string n;
        public string t;
        public int r;
        public StatBlock s;
    }

    [Serializable]
    public class TechDef
    {
        public string id;
        public string n;
        public string ty;
        public int r;
        public string el;
        public StatBlock e;
        public string[] sp;
    }

    [Serializable]
    public class AdventureStageDef
    {
        public int index;
        public string boss;
        public string location;
        public string element;
    }

    [Serializable]
    public class StanceDef
    {
        public string id;
        public string n;
        public float atk;
        public float def;
    }

    [Serializable]
    public class MutationDef
    {
        public string id;
        public string n;
    }

    [Serializable]
    public class AdventureData
    {
        public AdventureStageDef[] stages;
        public StanceDef[] stances;
        public MutationDef[] mutations;
    }

    [Serializable]
    public class OwnedTalent
    {
        public string id;
        public int lv = 1;
        public bool on;
    }

    [Serializable]
    public class OwnedItem
    {
        public string u;
        public string id;
        public int rf;
        public int ql;
        public bool lk;
        public bool ex;
    }

    [Serializable]
    public class OwnedTech
    {
        public string id;
        public int lv = 1;
        public bool eq;
    }

    [Serializable]
    public class EquippedSlots
    {
        public string weapon;
        public string armor;
        public string accessory;
        public string artifact;
    }

    [Serializable]
    public class PlayerState
    {
        public string saveId;
        public int rev = 1;
        public string name = "Vô Danh Tu Sĩ";
        public int realm = 0;
        public int layer = 0;
        public long xp = 0;
        public long totalXp = 0;
        public int age = 16;
        public int lifeBonus = 0;
        public long stones = 100;
        public int body = 0;
        public int root = 0;
        public int van = 0;
        public float pb = 0f;
        public float pity = 0f;
        public int toxin = 0;
        public bool tm = false;
        public int reborn = 0;
        public int ascended = 0;
        public float gfBuff = 0f;
        public float gfSup = 0f;
        public string activeArray = "";
        public string bmWeaponUid = "";
        public int bmLevel = 0;
        public int achCount = 0;

        public EquippedSlots eq = new EquippedSlots();
        public List<OwnedTalent> talents = new List<OwnedTalent>();
        public List<OwnedItem> inv = new List<OwnedItem>();
        public List<OwnedTech> techs = new List<OwnedTech>();
    }

    [Serializable]
    public class ComputedStats
    {
        public int the, linh, ngo, than, tam, van;
        public long luc, thu, toc, maxHp, maxMp;
        public float pen, crit, critDmg, dodge;
        public float tc, pb;
        public double realmMul;
    }

    [Serializable]
    public class FoeStats
    {
        public string name;
        public string element;
        public int stageIndex;
        public long hp;
        public long maxHp;
        public long luc;
        public long thu;
        public long toc;
    }
}
