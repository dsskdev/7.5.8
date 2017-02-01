using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "26378e33f8d3930b")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.5")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1058 with alias "umbracoSettings"
	/// <summary>Umbraco Settings</summary>
	public partial interface IUmbracoSettings : IPublishedContent
	{
		/// <summary>Umbraco Internal Redirect Id</summary>
		object UmbracoInternalRedirectId { get; }

		/// <summary>umbraco Navi Hide</summary>
		bool UmbracoNaviHide { get; }

		/// <summary>Umbraco Redirect</summary>
		object UmbracoRedirect { get; }

		/// <summary>Umbraco Sitemap Hide</summary>
		bool UmbracoSitemapHide { get; }

		/// <summary>Umbraco Url Alias</summary>
		string UmbracoUrlAlias { get; }

		/// <summary>Umbraco Url Name</summary>
		string UmbracoUrlName { get; }
	}

	/// <summary>Umbraco Settings</summary>
	[PublishedContentModel("umbracoSettings")]
	public partial class UmbracoSettings : PublishedContentModel, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbracoSettings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbracoSettings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoSettings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return GetUmbracoInternalRedirectId(this); }
		}

		/// <summary>Static getter for Umbraco Internal Redirect Id</summary>
		public static object GetUmbracoInternalRedirectId(IUmbracoSettings that) { return that.GetPropertyValue("umbracoInternalRedirectId"); }

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for umbraco Navi Hide</summary>
		public static bool GetUmbracoNaviHide(IUmbracoSettings that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return GetUmbracoRedirect(this); }
		}

		/// <summary>Static getter for Umbraco Redirect</summary>
		public static object GetUmbracoRedirect(IUmbracoSettings that) { return that.GetPropertyValue("umbracoRedirect"); }

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return GetUmbracoSitemapHide(this); }
		}

		/// <summary>Static getter for Umbraco Sitemap Hide</summary>
		public static bool GetUmbracoSitemapHide(IUmbracoSettings that) { return that.GetPropertyValue<bool>("umbracoSitemapHide"); }

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for Umbraco Url Alias</summary>
		public static string GetUmbracoUrlAlias(IUmbracoSettings that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return GetUmbracoUrlName(this); }
		}

		/// <summary>Static getter for Umbraco Url Name</summary>
		public static string GetUmbracoUrlName(IUmbracoSettings that) { return that.GetPropertyValue<string>("umbracoUrlName"); }
	}

	// Mixin content Type 1061 with alias "sEO"
	/// <summary>SEO</summary>
	public partial interface ISEO : IPublishedContent
	{
		/// <summary>Meta Description</summary>
		string MetaDescription { get; }

		/// <summary>Meta Title</summary>
		string MetaTitle { get; }
	}

	/// <summary>SEO</summary>
	[PublishedContentModel("sEO")]
	public partial class SEO : PublishedContentModel, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sEO";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SEO(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEO, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for Meta Description</summary>
		public static string GetMetaDescription(ISEO that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// Meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return GetMetaTitle(this); }
		}

		/// <summary>Static getter for Meta Title</summary>
		public static string GetMetaTitle(ISEO that) { return that.GetPropertyValue<string>("metaTitle"); }
	}

	// Mixin content Type 1066 with alias "content"
	/// <summary>Content</summary>
	public partial interface IContent : IPublishedContent
	{
		/// <summary>Heading</summary>
		string Heading { get; }

		/// <summary>Image</summary>
		string Image { get; }

		/// <summary>Link</summary>
		Newtonsoft.Json.Linq.JArray Link { get; }

		/// <summary>Main RTE</summary>
		IHtmlString MainRte { get; }
	}

	/// <summary>Content</summary>
	[PublishedContentModel("content")]
	public partial class Content : PublishedContentModel, IContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "content";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Content(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return GetHeading(this); }
		}

		/// <summary>Static getter for Heading</summary>
		public static string GetHeading(IContent that) { return that.GetPropertyValue<string>("heading"); }

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return GetImage(this); }
		}

		/// <summary>Static getter for Image</summary>
		public static string GetImage(IContent that) { return that.GetPropertyValue<string>("image"); }

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Newtonsoft.Json.Linq.JArray Link
		{
			get { return GetLink(this); }
		}

		/// <summary>Static getter for Link</summary>
		public static Newtonsoft.Json.Linq.JArray GetLink(IContent that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("link"); }

		///<summary>
		/// Main RTE
		///</summary>
		[ImplementPropertyType("mainRTE")]
		public IHtmlString MainRte
		{
			get { return GetMainRte(this); }
		}

		/// <summary>Static getter for Main RTE</summary>
		public static IHtmlString GetMainRte(IContent that) { return that.GetPropertyValue<IHtmlString>("mainRTE"); }
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return Content.GetHeading(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return Content.GetImage(this); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Newtonsoft.Json.Linq.JArray Link
		{
			get { return Content.GetLink(this); }
		}

		///<summary>
		/// Main RTE
		///</summary>
		[ImplementPropertyType("mainRTE")]
		public IHtmlString MainRte
		{
			get { return Content.GetMainRte(this); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Branch</summary>
	[PublishedContentModel("branch")]
	public partial class Branch : PublishedContentModel, IContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "branch";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Branch(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Branch, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return Content.GetHeading(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return Content.GetImage(this); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Newtonsoft.Json.Linq.JArray Link
		{
			get { return Content.GetLink(this); }
		}

		///<summary>
		/// Main RTE
		///</summary>
		[ImplementPropertyType("mainRTE")]
		public IHtmlString MainRte
		{
			get { return Content.GetMainRte(this); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Page</summary>
	[PublishedContentModel("page")]
	public partial class Page : PublishedContentModel, IContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "page";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Page(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return Content.GetHeading(this); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return Content.GetImage(this); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public Newtonsoft.Json.Linq.JArray Link
		{
			get { return Content.GetLink(this); }
		}

		///<summary>
		/// Main RTE
		///</summary>
		[ImplementPropertyType("mainRTE")]
		public IHtmlString MainRte
		{
			get { return Content.GetMainRte(this); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// Umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// Umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// Umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
