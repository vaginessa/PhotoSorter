﻿using System.Collections.Generic;

namespace PhotoSorter
{
    /// <summary>
    /// Represents a folder in the sort tree. E.g /2017 or /2017/March
    /// </summary>
    public struct Group
    {
        public static List<KeyValuePair<GroupType, string>> GroupTitles
            = new List<KeyValuePair<GroupType, string>>
            {
                new KeyValuePair<GroupType, string>(GroupType.YEAR, "Year"),
                new KeyValuePair<GroupType, string>(GroupType.MONTH, "Month"),
                new KeyValuePair<GroupType, string>(GroupType.DAY, "Day"),
                new KeyValuePair<GroupType, string>(GroupType.HOUR, "Hour")
            };

        public string Name { get; }
        public GroupType Type { get; }
        public List<Group> ChildrenGroups { get; set; }
        public List<PhotoInfo> Files { get; set; }

        public bool HasChildrenGroups => ChildrenGroups.Count > 0;

        public Group(string name, GroupType type)
        {
            Name = name;
            Type = type;
            ChildrenGroups = new List<Group>();
            Files = new List<PhotoInfo>();
        }
    }
}
