using System;
using System.Collections;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace Project
{
	public class ProjectView : View
	{
		internal const string CLICK_EVENT = "CLICK_EVENT";
		
		[Inject]
		public IEventDispatcher dispatcher{get;set;}
		
		internal void init()
		{
			
		}
		
		void Update()
		{
			
		}
		
		void onClick()
		{
			
		}
		
	}
	
}