using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskLog : IDirty
    {
        private Value<DateTime?> _addDate;
        public DateTime? AddDate { get { return _addDate; } set { _addDate = value; } }
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<string> _addedByUserId;
        public string AddedByUserId { get { return _addedByUserId; } set { _addedByUserId = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _completed;
        public bool? Completed { get { return _completed; } set { _completed = value; } }
        private Value<string> _completedBy;
        public string CompletedBy { get { return _completedBy; } set { _completedBy = value; } }
        private Value<string> _completedByUserId;
        public string CompletedByUserId { get { return _completedByUserId; } set { _completedByUserId = value; } }
        private Value<DateTime?> _completedDateUtc;
        public DateTime? CompletedDateUtc { get { return _completedDateUtc; } set { _completedDateUtc = value; } }
        private Value<int?> _contactCount;
        public int? ContactCount { get { return _contactCount; } set { _contactCount = value; } }
        private Value<List<MilestoneTaskContact>> _contacts;
        public List<MilestoneTaskContact> Contacts { get { return _contacts; } set { _contacts = value; } }
        private Value<string> _contactsXml;
        public string ContactsXml { get { return _contactsXml; } set { _contactsXml = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<int?> _daysToComplete;
        public int? DaysToComplete { get { return _daysToComplete; } set { _daysToComplete = value; } }
        private Value<int?> _daysToCompleteFromSetting;
        public int? DaysToCompleteFromSetting { get { return _daysToCompleteFromSetting; } set { _daysToCompleteFromSetting = value; } }
        private Value<DateTime?> _expectedDate;
        public DateTime? ExpectedDate { get { return _expectedDate; } set { _expectedDate = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isRequiredIndicator;
        public bool? IsRequiredIndicator { get { return _isRequiredIndicator; } set { _isRequiredIndicator = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<DateTime?> _milestoneTaskLogDateUtc;
        public DateTime? MilestoneTaskLogDateUtc { get { return _milestoneTaskLogDateUtc; } set { _milestoneTaskLogDateUtc = value; } }
        private Value<string> _priority;
        public string Priority { get { return _priority; } set { _priority = value; } }
        private Value<string> _stage;
        public string Stage { get { return _stage; } set { _stage = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _taskDescription;
        public string TaskDescription { get { return _taskDescription; } set { _taskDescription = value; } }
        private Value<string> _taskGuid;
        public string TaskGuid { get { return _taskGuid; } set { _taskGuid = value; } }
        private Value<string> _taskName;
        public string TaskName { get { return _taskName; } set { _taskName = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _addDate.Dirty
                    || _addedBy.Dirty
                    || _addedByUserId.Dirty
                    || _alerts.Dirty
                    || _alertsXml.Dirty
                    || _commentList.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _completed.Dirty
                    || _completedBy.Dirty
                    || _completedByUserId.Dirty
                    || _completedDateUtc.Dirty
                    || _contactCount.Dirty
                    || _contacts.Dirty
                    || _contactsXml.Dirty
                    || _dateUtc.Dirty
                    || _daysToComplete.Dirty
                    || _daysToCompleteFromSetting.Dirty
                    || _expectedDate.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isRequiredIndicator.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _milestoneTaskLogDateUtc.Dirty
                    || _priority.Dirty
                    || _stage.Dirty
                    || _systemId.Dirty
                    || _taskDescription.Dirty
                    || _taskGuid.Dirty
                    || _taskName.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _addDate.Dirty = value;
                _addedBy.Dirty = value;
                _addedByUserId.Dirty = value;
                _alerts.Dirty = value;
                _alertsXml.Dirty = value;
                _commentList.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _completed.Dirty = value;
                _completedBy.Dirty = value;
                _completedByUserId.Dirty = value;
                _completedDateUtc.Dirty = value;
                _contactCount.Dirty = value;
                _contacts.Dirty = value;
                _contactsXml.Dirty = value;
                _dateUtc.Dirty = value;
                _daysToComplete.Dirty = value;
                _daysToCompleteFromSetting.Dirty = value;
                _expectedDate.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isRequiredIndicator.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _milestoneTaskLogDateUtc.Dirty = value;
                _priority.Dirty = value;
                _stage.Dirty = value;
                _systemId.Dirty = value;
                _taskDescription.Dirty = value;
                _taskGuid.Dirty = value;
                _taskName.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}