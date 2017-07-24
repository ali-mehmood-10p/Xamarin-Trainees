using System;
using System.Collections.Generic;
using WMS.Components;
namespace WMS.Utils
{
    public class WMSRadioButtonsGroupManager
    {
        Dictionary<string, List<WMSRadioButton>> GroupedRadioButtons;

        public WMSRadioButtonsGroupManager()
        {
            GroupedRadioButtons = new Dictionary<string, List<WMSRadioButton>>();
        }

        public void Add(WMSRadioButton radioButton)
        {
            if (radioButton.GroupID == null)
            {
                throw new Exception("Radio button group id not specified");
            }

            List<WMSRadioButton> grp = null;
            if (GroupedRadioButtons.ContainsKey(radioButton.GroupID))
            {
                grp = GroupedRadioButtons[radioButton.GroupID];
            }
            else
            {
                grp = new List<WMSRadioButton>();
            }

            grp.Add(radioButton);
            GroupedRadioButtons[radioButton.GroupID] = grp;
        }

        public void Remove(WMSRadioButton radioButton)
        {
            if (radioButton.GroupID == null)
            {
                throw new Exception("Radio button group id not specified");
            }

            if (!GroupedRadioButtons.ContainsKey(radioButton.GroupID))
            {
                return;
            }

			List<WMSRadioButton> grp = GroupedRadioButtons[radioButton.GroupID];
            grp.Remove(radioButton);
            GroupedRadioButtons[radioButton.GroupID] = grp;
        }

        public void RemoveAll()
        {
            GroupedRadioButtons.Clear();
        }

        void ClearSelectionForGroupId(string GroupID)
        {
			if (!GroupedRadioButtons.ContainsKey(GroupID))
			{
				return;
			}

            List<WMSRadioButton> grp = GroupedRadioButtons[GroupID];
            foreach (WMSRadioButton rdButton in grp)
            {
                rdButton.SetStateTo(RadioButtonState.RadioButtonStateUnSelected);
            }
        }

        public void SelectRadioButton(WMSRadioButton radioButton)
        {
            ClearSelectionForGroupId(radioButton.GroupID);

			if (!GroupedRadioButtons.ContainsKey(radioButton.GroupID))
			{
				return;
			}

			List<WMSRadioButton> grp = GroupedRadioButtons[radioButton.GroupID];
            foreach (WMSRadioButton rdButton in grp)
            {
                if (rdButton == radioButton)
                {
                    rdButton.SetStateTo(RadioButtonState.RadioButtonStateSelected);
                    break;
                }
            }
        }
    }
}
