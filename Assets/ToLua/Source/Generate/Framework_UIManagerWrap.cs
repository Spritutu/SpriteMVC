﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_UIManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.UIManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SetGrey", SetGrey);
		L.RegFunction("Push", Push);
		L.RegFunction("Pop", Pop);
		L.RegFunction("PeekOrNull", PeekOrNull);
		L.RegFunction("ShowUI", ShowUI);
		L.RegFunction("ShowUI2", ShowUI2);
		L.RegFunction("HideUI", HideUI);
		L.RegFunction("CloseUI", CloseUI);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Grey", get_Grey, null);
		L.RegVar("NormalCanvas", get_NormalCanvas, null);
		L.RegVar("MapCanvas", get_MapCanvas, null);
		L.RegVar("GuideCanvas", get_GuideCanvas, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGrey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckObject<UnityEngine.UI.Image>(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetGrey(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Push(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.Push(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
			obj.Pop();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PeekOrNull(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
			UnityEngine.GameObject o = obj.PeekOrNull();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowUI(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.ShowUI(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
				obj.ShowUI(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
				LuaTable arg2 = ToLua.CheckLuaTable(L, 4);
				obj.ShowUI(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Framework.UIManager.ShowUI");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowUI2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.ShowUI2(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.ShowUI2(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Framework.UIManager.ShowUI2");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideUI(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.HideUI(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseUI(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.UIManager obj = (Framework.UIManager)ToLua.CheckObject<Framework.UIManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.CloseUI(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Grey(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.UIManager obj = (Framework.UIManager)o;
			UnityEngine.Material ret = obj.Grey;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Grey on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NormalCanvas(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.UIManager obj = (Framework.UIManager)o;
			UnityEngine.Transform ret = obj.NormalCanvas;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NormalCanvas on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MapCanvas(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.UIManager obj = (Framework.UIManager)o;
			UnityEngine.Transform ret = obj.MapCanvas;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MapCanvas on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GuideCanvas(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.UIManager obj = (Framework.UIManager)o;
			UnityEngine.Transform ret = obj.GuideCanvas;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GuideCanvas on a nil value");
		}
	}
}
