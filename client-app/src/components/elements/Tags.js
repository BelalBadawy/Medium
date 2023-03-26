import React, { useState } from "react";
import useData from "../../hooks/useData";
import { LoaderSpinner } from "./LoaderSpinner";

export const Tags = () => {
    let size = 5;

    const [displayCount, setDisplayCount] = useState(size);

    const { data, loading, error } = useData(
        "/Tags/List"
    );



    return (
        <aside className="widget widget_tag_cloud">
            <div className="widget-title">Tags</div>
            <div className="tagcloud">
                {loading && <LoaderSpinner />}
                {error &&
                    <li >
                        {error}
                    </li>
                }
                {data &&
                    data.slice(0, displayCount).map((tag) => (
                        <a href="#" key={tag.id}>
                            {tag.title}
                        </a>
                    ))
                }
                {data && data.length > displayCount &&
                    <i className="icofont-plus" onClick={() => { setDisplayCount(displayCount + size) }} style={{ cursor: 'pointer' }}></i>
                }
            </div>
        </aside>
    );
};
