﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GLuaProgressBarWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GLuaProgressBar), typeof(FairyGUI.GProgressBar));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("New", _CreateFairyGUI_GLuaProgressBar);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GLuaProgressBar(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GLuaProgressBar obj = new FairyGUI.GLuaProgressBar();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GLuaProgressBar.New");
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
			FairyGUI.GLuaProgressBar obj = (FairyGUI.GLuaProgressBar)ToLua.CheckObject(L, 1, typeof(FairyGUI.GLuaProgressBar));
			obj.Dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
