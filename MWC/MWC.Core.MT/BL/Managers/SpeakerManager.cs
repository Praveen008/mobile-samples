using System;
using System.Collections.Generic;

namespace MWC.BL.Managers
{
	public static class SpeakerManager
	{
		static SpeakerManager ()
		{
		}

		public static void UpdateSpeakerData()
		{
			DAL.DataManager.DeleteSpeakers ();
			DAL.DataManager.SaveSpeakers (SAL.MwcSiteParser.GetSpeakers ());			
		}
	
		public static IList<Speaker> GetSpeakers ()
		{
			var speakers = new List<Speaker> ( DAL.DataManager.GetSpeakers () );
			speakers.Sort( (s1, s2) => s1.Name.CompareTo (s2.Name));
			return speakers;
		}

		public static Speaker GetSpeaker (int speakerID)
		{
			return DAL.DataManager.GetSpeaker ( speakerID );
		}
	}
}
