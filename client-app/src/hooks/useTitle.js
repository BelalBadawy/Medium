import { useEffect } from "react";

export const useTitle = (title) => {

    useEffect(() => {
        document.title = `${title} - Blogy`;
    }, [title]);

    return null;
}