// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using OpenLiveWriter.ApplicationFramework.Preferences;

namespace OpenLiveWriter.PostEditor
{
    public class PostEditorPreferences : OpenLiveWriter.ApplicationFramework.Preferences.Preferences
    {
        public PostEditorPreferences() : base("Writer")
        {
        }

        public PostWindowBehavior PostWindowBehavior
        {
            get { return _postWindowBehavior; }
            set { _postWindowBehavior = value; Modified(); }
        }
        private PostWindowBehavior _postWindowBehavior;

        public bool ViewPostAfterPublish
        {
            get { return _viewPostAfterPublish; }
            set { _viewPostAfterPublish = value; Modified(); }
        }
        private bool _viewPostAfterPublish;

        public bool CloseWindowOnPublish
        {
            get { return _closeWindowOnPublish; }
            set { _closeWindowOnPublish = value; Modified(); }
        }
        private bool _closeWindowOnPublish;

        public bool TitleReminder
        {
            get { return _titleReminder; }
            set { _titleReminder = value; Modified(); }
        }
        private bool _titleReminder;

        public bool CategoryReminder
        {
            get { return _categoryReminder; }
            set { _categoryReminder = value; Modified(); }
        }
        private bool _categoryReminder;

        public bool TagReminder
        {
            get { return _tagReminder; }
            set { _tagReminder = value; Modified(); }
        }
        private bool _tagReminder;

        public bool AutoSaveDrafts
        {
            get { return _autoSaveDrafts; }
            set { _autoSaveDrafts = value; Modified(); }
        }
        private bool _autoSaveDrafts;

        public int AutoSaveMinutes
        {
            get { return _autoSaveMinutes; }
            set { _autoSaveMinutes = value; Modified(); }
        }
        private int _autoSaveMinutes;


        protected override void LoadPreferences()
        {
            PostWindowBehavior = PostEditorSettings.PostWindowBehavior;
            ViewPostAfterPublish = PostEditorSettings.ViewPostAfterPublish;
            CloseWindowOnPublish = PostEditorSettings.CloseWindowOnPublish;
            TitleReminder = PostEditorSettings.TitleReminder;
            CategoryReminder = PostEditorSettings.CategoryReminder;
            TagReminder = PostEditorSettings.TagReminder;
            AutoSaveDrafts = PostEditorSettings.AutoSaveDrafts;
            AutoSaveMinutes = PostEditorSettings.AutoSaveMinutes;
        }

        protected override void SavePreferences()
        {
            PostEditorSettings.PostWindowBehavior = PostWindowBehavior;
            PostEditorSettings.ViewPostAfterPublish = ViewPostAfterPublish;
            PostEditorSettings.CloseWindowOnPublish = CloseWindowOnPublish;
            PostEditorSettings.TitleReminder = TitleReminder;
            PostEditorSettings.CategoryReminder = CategoryReminder;
            PostEditorSettings.TagReminder = TagReminder;
            PostEditorSettings.AutoSaveDrafts = AutoSaveDrafts;
            PostEditorSettings.AutoSaveMinutes = AutoSaveMinutes;
        }

    }
}
