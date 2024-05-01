using System.Collections.Generic;
using System;
using System.Collections.Generic;

public class Skills
{
    public class SkillNode
    {
        public string SkillName { get; set; }
        public List<SkillNode> Dependencies { get; set; }

        public SkillNode(string skillName, List<SkillNode> dependencies)
        {
            SkillName = skillName;
            Dependencies = dependencies;
        }
    }

    public class SkillTree
    {
        private Dictionary<string, SkillNode> skillNodes;

        public SkillTree()
        {
            skillNodes = new Dictionary<string, SkillNode>();
        }

        public void AddSkillNode(string skillName, List<SkillNode> dependencies)
        {
            if (skillNodes.ContainsKey(skillName))
            {
                throw new ArgumentException("Skill already exists in the skill tree.");
            }

            SkillNode newNode = new SkillNode(skillName, dependencies);
            skillNodes.Add(skillName, newNode);
        }

        public bool HasRequiredSkills(string targetSkill, List<string> acquiredSkills)
        {
            if (!skillNodes.ContainsKey(targetSkill))
            {
                throw new KeyNotFoundException("Target skill not found in the skill tree.");
            }

            SkillNode targetNode = skillNodes[targetSkill];

            foreach (var dependency in targetNode.Dependencies)
            {
                bool hasDependency = acquiredSkills.Contains(dependency.SkillName);

                if (!hasDependency)
                {
                    return false;
                }
            }

            return true;
        }
    }
    public Dictionary<string, object> Observation { get; set; } = new Dictionary<string, object>
    {
        ["Identify"] = new Dictionary<string, object>
        {
            ["Recognize"] = new Dictionary<string, object>
            {
                ["Comparison"] = new Dictionary<string, object>
                {
                    ["Alchemy"] = new Dictionary<string, object>
                    {
                        ["Medicine"] = new Dictionary<string, object>(),
                        ["Poison"] = new Dictionary<string, object>()
                    },
                    ["Games"] = new Dictionary<string, object>()
                },
                ["Forage"] = new Dictionary<string, object>
                {
                    ["Farm"] = new Dictionary<string, object>()
                },
                ["Crime"] = new Dictionary<string, object>
                {
                    ["Sneak"] = new Dictionary<string, object>(),
                    ["Lockpick"] = new Dictionary<string, object>(),
                    ["Pickpocket"] = new Dictionary<string, object>()
                }
            },
            ["Social"] = new Dictionary<string, object>
            {
                ["Barter"] = new Dictionary<string, object>
                {
                    ["Negotiate"] = new Dictionary<string, object>(),
                    ["Influence"] = new Dictionary<string, object>
                    {
                        ["Slander"] = new Dictionary<string, object>()
                    },
                    ["Animal"] = new Dictionary<string, object>
                    {
                        ["Ride"] = new Dictionary<string, object>(),
                        ["Tame"] = new Dictionary<string, object>
                        {
                            ["Domesticate"] = new Dictionary<string, object>(),
                            ["Breed"] = new Dictionary<string, object>
                            {
                                ["Genealogy"] = new Dictionary<string, object>()
                            }
                        }
                    }
                },
                ["Linguistic"] = new Dictionary<string, object>
                {
                    ["Literature"] = new Dictionary<string, object>()
                },
                ["Leadership"] = new Dictionary<string, object>
                {
                    ["Persuade"] = new Dictionary<string, object>(),
                    ["Intimidate"] = new Dictionary<string, object>()
                },
                ["Command"] = new Dictionary<string, object>
                {
                    ["Delegate"] = new Dictionary<string, object>(),
                    ["Plan"] = new Dictionary<string, object>
                    {
                        ["Strategy"] = new Dictionary<string, object>()
                    },
                    ["Tactics"] = new Dictionary<string, object>()
                }
            },
            ["Personal"] = new Dictionary<string, object>
            {
                ["Survival"] = new Dictionary<string, object>
                {
                    ["Firemake"] = new Dictionary<string, object>
                    {
                        ["Chemicals"] = new Dictionary<string, object>
                        {
                            ["Radiology"] = new Dictionary<string, object>()
                        }
                    },
                    ["Cook"] = new Dictionary<string, object>
                    {
                        ["Bake"] = new Dictionary<string, object>()
                    },
                    ["Shelter"] = new Dictionary<string, object>
                    {
                        ["Camp"] = new Dictionary<string, object>(),
                        ["House"] = new Dictionary<string, object>
                        {
                            ["Village"] = new Dictionary<string, object>
                            {
                                ["Town"] = new Dictionary<string, object>
                                {
                                    ["City"] = new Dictionary<string, object>()
                                }
                            },
                            ["Castle"] = new Dictionary<string, object>()
                        }
                    },
                    ["Hunt"] = new Dictionary<string, object>
                    {
                        ["Skin"] = new Dictionary<string, object>
                        {
                            ["Tan"] = new Dictionary<string, object>()
                        },
                        ["Gut"] = new Dictionary<string, object>(),
                        ["Traps"] = new Dictionary<string, object>()
                    }
                },
                ["Learn"] = new Dictionary<string, object>
                {
                    ["Teach"] = new Dictionary<string, object>(),
                    ["Logic"] = new Dictionary<string, object>
                    {
                        ["Explore"] = new Dictionary<string, object>
                        {
                            ["Scout"] = new Dictionary<string, object>(),
                            ["Pathfind"] = new Dictionary<string, object>(),
                            ["Prospect"] = new Dictionary<string, object>(),
                            ["Discover"] = new Dictionary<string, object>(),
                            ["Naval"] = new Dictionary<string, object>
                            {
                                ["Sail"] = new Dictionary<string, object>
                                {
                                    ["Pilot"] = new Dictionary<string, object>()
                                }
                            }
                        },
                        ["Biology"] = new Dictionary<string, object>
                        {
                            ["Physics"] = new Dictionary<string, object>()
                        },
                        ["Ecology"] = new Dictionary<string, object>
                        {
                            ["Zoology"] = new Dictionary<string, object>()
                        },
                        ["Geology"] = new Dictionary<string, object>
                        {
                            ["Chronology"] = new Dictionary<string, object>()
                        },
                        ["Psychology"] = new Dictionary<string, object>
                        {
                            ["Neurology"] = new Dictionary<string, object>()
                        },
                        ["Sociology"] = new Dictionary<string, object>
                        {
                            ["Mythology"] = new Dictionary<string, object>()
                        }
                    }
                },
                ["Athletic"] = new Dictionary<string, object>
                {
                    ["Acrobatics"] = new Dictionary<string, object>
                    {
                        ["Dodge"] = new Dictionary<string, object>
                        {
                            ["Parry"] = new Dictionary<string, object>()
                        }
                    },
                    ["Sports"] = new Dictionary<string, object>(),
                    ["Mine"] = new Dictionary<string, object>(),
                    ["Push"] = new Dictionary<string, object>()
                },
                ["Combat"] = new Dictionary<string, object>
                {
                    ["Punch"] = new Dictionary<string, object>(),
                    ["Defense"] = new Dictionary<string, object>
                    {
                        ["Block"] = new Dictionary<string, object>
                        {
                            ["ShieldBash"] = new Dictionary<string, object>()
                        },
                        ["Armour"] = new Dictionary<string, object>(),
                        ["Incapacitate"] = new Dictionary<string, object>()
                    },
                    ["Offense"] = new Dictionary<string, object>
                    {
                        ["Stab"] = new Dictionary<string, object>
                        {
                            ["Lunge"] = new Dictionary<string, object>()
                        },
                        ["Slice"] = new Dictionary<string, object>()
                    },
                    ["Melee"] = new Dictionary<string, object>
                    {
                        ["DualWield"] = new Dictionary<string, object>()
                    },
                    ["Ranged"] = new Dictionary<string, object>
                    {
                        ["Loose"] = new Dictionary<string, object>
                        {
                            ["Volley"] = new Dictionary<string, object>(),
                            ["Pinpoint"] = new Dictionary<string, object>()
                        }
                    }
                },
                ["Craft"] = new Dictionary<string, object>
                {
                    ["Weave"] = new Dictionary<string, object>(),
                    ["Blacksmith"] = new Dictionary<string, object>(),
                    ["Pottery"] = new Dictionary<string, object>(),
                    ["Construct"] = new Dictionary<string, object>
                    {
                        ["Masonry"] = new Dictionary<string, object>(),
                        ["Engineer"] = new Dictionary<string, object>()
                    }
                }
            }
        }
    };
}

