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
	
	
	public partial class MoonActivity
	{
		
		private ImageView _generated_field_28;
		
		private TextView _generated_field_29;
		
		private Button _generated_field_30;
		
		private ILocalizationService _generated_field_31;
		
		protected ImageView night
		{
			get
			{
				if ((this._generated_field_28 == null))
				{
					this._generated_field_28 = this.FindViewById<ImageView>(Resource.Id.night);
				}
				return this._generated_field_28;
			}
		}
		
		protected TextView in_moon
		{
			get
			{
				if ((this._generated_field_29 == null))
				{
					this._generated_field_29 = this.FindViewById<TextView>(Resource.Id.in_moon);
				}
				return this._generated_field_29;
			}
		}
		
		protected Button back
		{
			get
			{
				if ((this._generated_field_30 == null))
				{
					this._generated_field_30 = this.FindViewById<Button>(Resource.Id.back);
				}
				return this._generated_field_30;
			}
		}
		
		protected ILocalizationService Generated_LocalizationService
		{
			get
			{
				if ((this._generated_field_31 == null))
				{
					this._generated_field_31 = DependencyService.Container.Resolve<ILocalizationService>();
				}
				return this._generated_field_31;
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
			BindingObject generated_bindingObject_7 = new BindingObject(this.back);
			result.Add(generated_bindingObject_7);
			BindingExpression generated_bindingExpression_7 = new BindingExpression("Click", "ButtonBack");
			generated_bindingObject_7.AddExpression(generated_bindingExpression_7);
			return result;
		}
	}
}
