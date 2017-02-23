/// <binding BeforeBuild='copyapp, copy' Clean='cleanapp, clean' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/
var gulp = require("gulp"),
    rimraf = require("rimraf"),
    fs = require("fs");
var paths = {
    node_modules_src: "./node_modules/",
    node_modules: "./wwwroot/node_modules/",
    app_src: "./app/",
    app: "./wwwroot/app/",
};
gulp.task("clean",
    function (cb) {
        rimraf(paths.node_modules, cb);
    });
gulp.task("copy",
    ["clean"],
    function () {
        var directories = {
            "core-js": "core-js/**/*.{js,map}",
            "jquery": "jquery/**/*.{js,map}",
            "zone.js": "zone\.js/**/*.{js,map}",
            "reflect-metadata": "reflect-metadata/**/*.{js,map}",
            "systemjs": "systemjs/**/*.{js,map}",
            "@angular": "@angular/**/*.{js,map}",
            "angular2-in-memory-web-api": "angular2-in-memory-web-api/**/*.{js,map}",
            "rxjs": "rxjs/**/*.{js,map}",
        }
        for (var directory in directories) {
            var pattern = directories[directory];
            gulp.src(paths.node_modules_src + pattern)
                .pipe(gulp.dest(paths.node_modules + directory));
        }
    });
gulp.task("cleanapp",
    function (cb) {
        rimraf(paths.app, cb);
    });
gulp.task("copyapp",
    ["clean"],
    function () {
        gulp.src(paths.app_src + "*.{js,map}")
            .pipe(gulp.dest(paths.app));
    });