using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomTimeLabelText
{
    public class ScheduleBehavior : Behavior<ContentPage>
    {
        SfSchedule schedule;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            schedule = bindable.FindByName<SfSchedule>("schedule");
            schedule.TimeInterval = 1;

            WeekViewSettings weekViewSettings = new WeekViewSettings();
            weekViewSettings.WorkStartHour = 0;
            weekViewSettings.WorkEndHour = 23;
            WeekLabelSettings weekLabelSettings = new WeekLabelSettings();
            weekLabelSettings.TimeFormat = string.Format("'Room'") + " " + "HH";

            weekViewSettings.WeekLabelSettings = weekLabelSettings;
            schedule.WeekViewSettings = weekViewSettings;

            TimelineViewSettings timelineViewSettings = new TimelineViewSettings();
            timelineViewSettings.StartHour = 0;
            timelineViewSettings.EndHour = 1;
            schedule.TimelineViewSettings = timelineViewSettings;
            TimelineLabelSettings labelSettings = new TimelineLabelSettings();
            labelSettings.TimeFormat = string.Format(" 'Room' ") + " " + "mm";
            timelineViewSettings.LabelSettings = labelSettings;
        }
    }
}
