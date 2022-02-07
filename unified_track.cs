
class UnifiedTrack
{

    List<Camera> cameras;
    List<Track> tracks;
    addCamera(int beg, int end) {
        if (checkConflict(beg, end)) {
            Camera cam = new Camera();
            cam.setTime(beg, end);
            cameras.add(cam);
        }
    }

    void setCameraTransform() {
        int camMode = getCameraMode();
        // bindobj

        // control

    }

    record();

    output_video();

}