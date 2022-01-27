
// load
string sceneName;
Scene scene =  load_scene(sceneName);

List[StaticModelObject] staticObjs;
List[DynamicModelObject] dynamicObjs;
while(loadFlag) {
    m = load_static_object(modelName, deafaultPos);
    staticObjs.add(m);
    m2 = load_dynamic_object(modelName, deafaultPos);
    dynamicObjs.add(m2);
}
            

// edit timeline
// 控制
applyControl();

while (notEnd) {
    Transform trans = getTransform();
    Action trans = getTransform();
    wait(1/24);
}