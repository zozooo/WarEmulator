﻿/*
 * Copyright (C) 2011 APS
 *	http://AllPrivateServer.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FrameWork;

namespace Common
{
    // Valeur Fixe d'un character
    [DataTable(PreCache = false, TableName = "GameObject_spawns", DatabaseName = "World")]
    [Serializable]
    public class GameObject_spawn : DataObject
    {
        public GameObject_proto Proto;

        [PrimaryKey(AutoIncrement=true)]
        public uint Guid;

        [DataElement()]
        public uint Entry;

        [DataElement()]
        public ushort ZoneId;

        [DataElement()]
        public int WorldX;

        [DataElement()]
        public int WorldY;

        [DataElement()]
        public int WorldZ;

        [DataElement()]
        public int WorldO;

        [DataElement()]
        public uint DisplayID;
    }
}