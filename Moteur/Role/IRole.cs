﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Role
{
    public interface IRole
    {
        public string Name { get; }
        public string Description { get; }
        public string Image { get; }
        public int DailyVotePoder();
        public int NightVotePoder();
        public int NightOrder();
        public void NightAction();
        public void Die();
        public void Victory();
        public bool IsSubRole();
        public EnumTeam GetTeam();
    }
}
