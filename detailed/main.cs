
// load
string sceneName = getSceneName();
Scene scene =  load_scene(sceneName);

List[StaticModelObject] staticObjs;
List[DynamicModelObject] dynamicObjs;
while(loadFlag) {
    m = load_static_object(modelName, deafaultPos);
    staticObjs.add(m);
    m2 = load_dynamic_object(modelName, deafaultPos);
    dynamicObjs.add(m2);
}
            

List[Track] tracks = new List[Track]();

// 编辑各个tracks
while (true) {
    BindedObject selectedObj = selectObj();
    if (selectedObj == null) break;
    Track aTrack = new Track(selectedObj);
    int controlMode = getControlMode();
    if (controlMode == cmode.SINGLE) {
        // 单体运动
        aTrack.recordByControl();
    } else if (controlMode == cmode.BINDED) {
        // 绑定运动
        Track faTrack = getFatherTrack();
        Transform bias = getbiasTransform();
        aTrack.bindedWithBias(faTrack, bias, randomTrans);
    }

    tracks.push(aTrack);
}


// 放置各个Track
UnifiedTrack uniTrack = new UnifiedTrack(tracks);

while(true) {
    camInfo = getNewCamera();
    uniTrack.addCamera(camInfo.beg, camInfo.end);
    uniTrack.setLastCameraTransform();
}

uniTrack.play();
uniTrack.output_video(video_name, video_format);



