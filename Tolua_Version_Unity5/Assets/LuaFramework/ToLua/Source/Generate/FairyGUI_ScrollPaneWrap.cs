﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_ScrollPaneWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.ScrollPane), typeof(FairyGUI.EventDispatcher));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("SetPercX", SetPercX);
		L.RegFunction("SetPercY", SetPercY);
		L.RegFunction("SetPosX", SetPosX);
		L.RegFunction("SetPosY", SetPosY);
		L.RegFunction("SetCurrentPageX", SetCurrentPageX);
		L.RegFunction("SetCurrentPageY", SetCurrentPageY);
		L.RegFunction("ScrollTop", ScrollTop);
		L.RegFunction("ScrollBottom", ScrollBottom);
		L.RegFunction("ScrollUp", ScrollUp);
		L.RegFunction("ScrollDown", ScrollDown);
		L.RegFunction("ScrollLeft", ScrollLeft);
		L.RegFunction("ScrollRight", ScrollRight);
		L.RegFunction("ScrollToView", ScrollToView);
		L.RegFunction("IsChildInView", IsChildInView);
		L.RegFunction("CancelDragging", CancelDragging);
		L.RegFunction("New", _CreateFairyGUI_ScrollPane);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onScroll", get_onScroll, null);
		L.RegVar("onScrollEnd", get_onScrollEnd, null);
		L.RegVar("onPullDownRelease", get_onPullDownRelease, null);
		L.RegVar("onPullUpRelease", get_onPullUpRelease, null);
		L.RegVar("draggingPane", get_draggingPane, null);
		L.RegVar("owner", get_owner, null);
		L.RegVar("bouncebackEffect", get_bouncebackEffect, set_bouncebackEffect);
		L.RegVar("touchEffect", get_touchEffect, set_touchEffect);
		L.RegVar("inertiaDisabled", get_inertiaDisabled, set_inertiaDisabled);
		L.RegVar("softnessOnTopOrLeftSide", get_softnessOnTopOrLeftSide, set_softnessOnTopOrLeftSide);
		L.RegVar("scrollStep", get_scrollStep, set_scrollStep);
		L.RegVar("snapToItem", get_snapToItem, set_snapToItem);
		L.RegVar("mouseWheelEnabled", get_mouseWheelEnabled, set_mouseWheelEnabled);
		L.RegVar("decelerationRate", get_decelerationRate, set_decelerationRate);
		L.RegVar("percX", get_percX, set_percX);
		L.RegVar("percY", get_percY, set_percY);
		L.RegVar("posX", get_posX, set_posX);
		L.RegVar("posY", get_posY, set_posY);
		L.RegVar("isBottomMost", get_isBottomMost, null);
		L.RegVar("isRightMost", get_isRightMost, null);
		L.RegVar("currentPageX", get_currentPageX, set_currentPageX);
		L.RegVar("currentPageY", get_currentPageY, set_currentPageY);
		L.RegVar("scrollingPosX", get_scrollingPosX, null);
		L.RegVar("scrollingPosY", get_scrollingPosY, null);
		L.RegVar("contentWidth", get_contentWidth, null);
		L.RegVar("contentHeight", get_contentHeight, null);
		L.RegVar("viewWidth", get_viewWidth, set_viewWidth);
		L.RegVar("viewHeight", get_viewHeight, set_viewHeight);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_ScrollPane(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 7)
			{
				FairyGUI.GComponent arg0 = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
				FairyGUI.ScrollType arg1 = (FairyGUI.ScrollType)ToLua.CheckObject(L, 2, typeof(FairyGUI.ScrollType));
				FairyGUI.Margin arg2 = (FairyGUI.Margin)ToLua.CheckObject(L, 3, typeof(FairyGUI.Margin));
				FairyGUI.ScrollBarDisplayType arg3 = (FairyGUI.ScrollBarDisplayType)ToLua.CheckObject(L, 4, typeof(FairyGUI.ScrollBarDisplayType));
				int arg4 = (int)LuaDLL.luaL_checknumber(L, 5);
				string arg5 = ToLua.CheckString(L, 6);
				string arg6 = ToLua.CheckString(L, 7);
				FairyGUI.ScrollPane obj = new FairyGUI.ScrollPane(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.ScrollPane.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			obj.Dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPercX(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetPercX(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPercY(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetPercY(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosX(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetPosX(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosY(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetPosY(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentPageX(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetCurrentPageX(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentPageY(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetCurrentPageY(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollTop(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				obj.ScrollTop();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				obj.ScrollTop(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollTop");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollBottom(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				obj.ScrollBottom();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				obj.ScrollBottom(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollBottom");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollUp(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				obj.ScrollUp();
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(float), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.ScrollUp(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollUp");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollDown(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				obj.ScrollDown();
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(float), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.ScrollDown(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollDown");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollLeft(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				obj.ScrollLeft();
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(float), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.ScrollLeft(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollLeft");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollRight(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				obj.ScrollRight();
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(float), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.ScrollRight(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollRight");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollToView(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(FairyGUI.GObject)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				obj.ScrollToView(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(FairyGUI.GObject), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.ScrollToView(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(UnityEngine.Rect), typeof(bool), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				UnityEngine.Rect arg0 = (UnityEngine.Rect)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				bool arg2 = LuaDLL.lua_toboolean(L, 4);
				obj.ScrollToView(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.ScrollPane), typeof(FairyGUI.GObject), typeof(bool), typeof(bool)))
			{
				FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				bool arg2 = LuaDLL.lua_toboolean(L, 4);
				obj.ScrollToView(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.ScrollPane.ScrollToView");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsChildInView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			bool o = obj.IsChildInView(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancelDragging(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)ToLua.CheckObject(L, 1, typeof(FairyGUI.ScrollPane));
			obj.CancelDragging();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			FairyGUI.EventListener ret = obj.onScroll;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onScroll on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScrollEnd(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			FairyGUI.EventListener ret = obj.onScrollEnd;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onScrollEnd on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPullDownRelease(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			FairyGUI.EventListener ret = obj.onPullDownRelease;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onPullDownRelease on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPullUpRelease(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			FairyGUI.EventListener ret = obj.onPullUpRelease;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onPullUpRelease on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_draggingPane(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FairyGUI.ScrollPane.draggingPane);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_owner(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			FairyGUI.GComponent ret = obj.owner;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index owner on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bouncebackEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.bouncebackEffect;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index bouncebackEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.touchEffect;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index touchEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inertiaDisabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.inertiaDisabled;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index inertiaDisabled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softnessOnTopOrLeftSide(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.softnessOnTopOrLeftSide;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index softnessOnTopOrLeftSide on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollStep(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.scrollStep;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollStep on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_snapToItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.snapToItem;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index snapToItem on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mouseWheelEnabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.mouseWheelEnabled;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mouseWheelEnabled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_decelerationRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.decelerationRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index decelerationRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_percX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.percX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index percX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_percY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.percY;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index percY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_posX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.posX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index posX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_posY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.posY;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index posY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isBottomMost(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.isBottomMost;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isBottomMost on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isRightMost(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool ret = obj.isRightMost;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isRightMost on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentPageX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			int ret = obj.currentPageX;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index currentPageX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentPageY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			int ret = obj.currentPageY;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index currentPageY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollingPosX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.scrollingPosX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollingPosX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollingPosY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.scrollingPosY;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollingPosY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.contentWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index contentWidth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.contentHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index contentHeight on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_viewWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.viewWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewWidth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_viewHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float ret = obj.viewHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewHeight on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bouncebackEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.bouncebackEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index bouncebackEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_touchEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.touchEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index touchEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_inertiaDisabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.inertiaDisabled = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index inertiaDisabled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softnessOnTopOrLeftSide(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.softnessOnTopOrLeftSide = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index softnessOnTopOrLeftSide on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollStep(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.scrollStep = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollStep on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_snapToItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.snapToItem = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index snapToItem on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mouseWheelEnabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.mouseWheelEnabled = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mouseWheelEnabled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_decelerationRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.decelerationRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index decelerationRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_percX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.percX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index percX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_percY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.percY = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index percY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_posX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.posX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index posX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_posY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.posY = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index posY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_currentPageX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.currentPageX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index currentPageX on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_currentPageY(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.currentPageY = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index currentPageY on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_viewWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.viewWidth = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewWidth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_viewHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.ScrollPane obj = (FairyGUI.ScrollPane)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.viewHeight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewHeight on a nil value" : e.Message);
		}
	}
}

