﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisAdmin.DataModels
{
    /// <summary>
    /// The current page of application
    /// </summary>
    public enum ApplicationPage
    {
        CommonLessonSettings = 0,
        LessonSettingsOptionRadio,
        LessonSettingsOptionTest,
        LessonSettingsProgramComsecKeys,
        LessonSettingsRadioStationStatus,
    }

    public class ApplicationPageContainer
    {
        
        public Dictionary<ApplicationPage, object> Pages { get; private set; }
        private Dictionary<Type, ApplicationPage> PagesByObject { get; set; }

        ApplicationPageContainer()
        {
            Pages = new Dictionary<ApplicationPage, object>() {
                {ApplicationPage.CommonLessonSettings, new Pages.CommonLessonSettings() },
                {ApplicationPage.LessonSettingsOptionRadio, new Pages.LessonSettingsOptionRadio() },
                {ApplicationPage.LessonSettingsOptionTest, new Pages.LessonSettingsOptionTest() },
                {ApplicationPage.LessonSettingsRadioStationStatus, new Pages.LessonSettingsStationStatus() },
                {ApplicationPage.LessonSettingsProgramComsecKeys, new Pages.LessonSettingsProgramComsecKeys() },
            };

            PagesByObject = new Dictionary<Type, ApplicationPage>();
            foreach (var page in Pages)
            {
                PagesByObject.Add(page.Value.GetType(), page.Key);
            }
        }

        public static ApplicationPageContainer Contrainer { get; } = new ApplicationPageContainer();
        
        public T GetPage<T> ()
        {
            if (PagesByObject.ContainsKey(typeof(T)))
            {
                return (T)Pages[PagesByObject[typeof(T)]];
            }
            return default;
        }

    }
}
