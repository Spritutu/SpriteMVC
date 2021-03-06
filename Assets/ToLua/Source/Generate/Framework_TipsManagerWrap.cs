﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_TipsManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.TipsManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("OnInit", OnInit);
		L.RegFunction("ShowTips", ShowTips);
		L.RegFunction("ShowReduceTips", ShowReduceTips);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("TipsCanvas", get_TipsCanvas, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
			obj.OnInit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowTips(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.ShowTips(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<float>(L, 3))
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				obj.ShowTips(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Vector3>(L, 3))
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.ShowTips(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<string>(L, 3))
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				obj.ShowTips(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<float, float>(L, 3))
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.ShowTips(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<UnityEngine.Vector3, float>(L, 3))
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.ShowTips(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, float>(L, 3))
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.ShowTips(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Framework.TipsManager.ShowTips");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowReduceTips(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.ShowReduceTips(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				Framework.TipsManager obj = (Framework.TipsManager)ToLua.CheckObject<Framework.TipsManager>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				obj.ShowReduceTips(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Framework.TipsManager.ShowReduceTips");
			}
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
	static int get_TipsCanvas(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.TipsManager obj = (Framework.TipsManager)o;
			UnityEngine.Transform ret = obj.TipsCanvas;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TipsCanvas on a nil value");
		}
	}
}

