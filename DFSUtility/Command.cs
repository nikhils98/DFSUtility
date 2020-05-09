﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DFSUtility
{
    public enum Command
    {
        clientConnect,
        requestFileTree,
        serverConnect,
        openFile,
        updateFile,
        ls,
        cd,
        mkdir,
        rmdir,
        rm,
        mvdir,
        mv,
        cpdir,
        cp,
        stats,
        save,
        updateFileTree,
        updateConfig,
        forwarded
    }
}