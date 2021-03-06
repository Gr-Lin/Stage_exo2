//------------------------------------------------------------------------------
// This file was generated by binding preprocessing system for Android
//------------------------------------------------------------------------------

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Sky;
using Storm.Generated;
using Storm.Mvvm;
using Storm.Mvvm.Bindings;
using Storm.Mvvm.Components;
using Storm.Mvvm.Inject;
using Storm.Mvvm.Services;
using Storm.Mvvm.TemplateSelectors;
using System;
using System.Collections.Generic;
using System.Reflection;


namespace Sky.Activities
{
	
	
	public partial class SunActivity
	{
		
		private ImageView _generated_field_24;
		
		private TextView _generated_field_25;
		
		private Button _generated_field_26;
		
		private ILocalizationService _generated_field_27;
		
		protected ImageView day
		{
			get
			{
				if ((this._generated_field_24 == null))
				{
					this._generated_field_24 = this.FindViewById<ImageView>(Resource.Id.day);
				}
				return this._generated_field_24;
			}
		}
		
		protected TextView in_sky
		{
			get
			{
				if ((this._generated_field_25 == null))
				{
					this._generated_field_25 = this.FindViewById<TextView>(Resource.Id.in_sky);
				}
				return this._generated_field_25;
			}
		}
		
		protected Button change
		{
			get
			{
				if ((this._generated_field_26 == null))
				{
					this._generated_field_26 = this.FindViewById<Button>(Resource.Id.change);
				}
				return this._generated_field_26;
			}
		}
		
		protected ILocalizationService Generated_LocalizationService
		{
			get
			{
				if ((this._generated_field_27 == null))
				{
					this._generated_field_27 = DependencyService.Container.Resolve<ILocalizationService>();
				}
				return this._generated_field_27;
			}
		}
		
		private void Generated_AssignTranslation()
		{
		}
		
		private void Generated_AssignResourceForResource()
		{
		}
		
		private void Generated_AssignResourceForView()
		{
		}
		
		protected override List<BindingObject> GetBindingPaths()
		{
			this.Generated_AssignTranslation();
			this.Generated_AssignResourceForResource();
			this.Generated_AssignResourceForView();
			List<BindingObject> result = new List<BindingObject>();
			BindingObject generated_bindingObject_6 = new BindingObject(this.change);
			result.Add(generated_bindingObject_6);
			BindingExpression generated_bindingExpression_6 = new BindingExpression("Click", "ButtonChange");
			generated_bindingObject_6.AddExpression(generated_bindingExpression_6);
			return result;
		}
	}
}
